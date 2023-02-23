using Microsoft.AspNetCore.Mvc;
using MoMoEmbedd.Extensions;
using MoMoEmbedd.Models;
using MoMoVariable;
using Newtonsoft.Json.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Net;

namespace MoMoEmbedd.Controllers
{
    public class HomeController : Controller
    {
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        SqlConnection con = new SqlConnection();
        List<Payment> payments = new List<Payment>();
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            con.ConnectionString = MoMoEmbedd.Properties.Resources.ConnectionStr;
        }
        public ActionResult PaymentWithMoMo()
        {
            string endpoint = "https://test-payment.momo.vn/v2/gateway/api/create";
            string partnerCode = "MOMO5RGX20191128";
            string accessKey = "M8brj9K6E22vXoDB";
            string serectKey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
            string orderInfo = "DH" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string ReturnUrl = "http://gateway.momo.com/Home/ReturnUrl/";
            string ipnUrl = "https://webhook.site/b3088a6a-2d17-4f8d-a383-71389a6c600b";
            string amount = "1000";
            string requestType = "captureWallet";

            string orderid = Guid.NewGuid().ToString();
            string requestId = Guid.NewGuid().ToString();
            string extraData = "";

            string rawHash = "accessKey=" + accessKey +
                "&amount=" + amount +
                "&extraData=" + extraData +
                "&ipnUrl=" + ipnUrl +
                "&orderId=" + orderid +
                "&orderInfo=" + orderInfo +
                "&partnerCode=" + partnerCode +
                "&redirectUrl=" + ReturnUrl +
                "&requestId=" + requestId +
                "&requestType=" + requestType
                ;

            MoMoSecurity crypto = new MoMoSecurity();
            string signature = crypto.signSHA256(rawHash, serectKey);
            JObject message = new JObject
            {
                { "partnerCode", partnerCode },
                { "partnerName", "Test" },
                { "storeId", "MomoTestStore" },
                { "requestId", requestId },
                { "amount", amount },
                { "orderId", orderid },
                { "orderInfo", orderInfo },
                { "redirectUrl", ReturnUrl },
                { "ipnUrl", ipnUrl },
                { "lang", "en" },
                { "extraData", extraData },
                { "requestType", requestType },
                { "signature", signature }

            };
            string responseFromMomo = PaymentRequest.sendPaymentRequest(endpoint, message.ToString());
            JObject jmessage = JObject.Parse(responseFromMomo);
            return Redirect(jmessage.GetValue("payUrl").ToString());
        }
        public IActionResult ReturnUrl()
        {
            string param = Request.QueryString.ToString().Substring(0, Request.QueryString.ToString().IndexOf("signature") - 1);
            param = WebUtility.UrlDecode(param);
            MoMoSecurity crypto = new MoMoSecurity();
            string serectKey = "nqQiVSgDMy809JoPF6OzP5OdBUB550Y4";
            string signature = crypto.signSHA256(param, serectKey);
            if (Request.Query["errorCode"].Equals("0"))
            {
                ViewBag.message = "Thanh toán thất bại";
                return View();
            }
            //else if (signature != Request.Form["signature"].ToString())
            //{
            //    ViewBag.message = "Thông tin request không hợp lệ";
            //    return View();
            //}

            else
            {
                FetchTable();

                ViewBag.message = "Thanh toán Thành công! Quý khách vui lòng Kiểm tra thông tin Đặt Vé";
                return View(payments);
            }

        }
        public void FetchTable()
        {
            if (payments.Count > 0)
            {
                payments.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                var json = @"[{""ID"":""90"",""Type"":1,""ShowTimesID"":""LC01"",""SeatName"":""A1"",""CustomerID"":""KH01"",""PaymentType"":""Chưa được Đặt"",""Price"":85000.0,""Status"":0},{""ID"":""89"",""Type"":1,""ShowTimesID"":""LC01"",""SeatName"":""A2"",""CustomerID"":""KH01"",""PaymentType"":""Chưa được Đặt"",""Price"":85000.0,""Status"":0},{""ID"":""75"",""Type"":1,""ShowTimesID"":""LC01"",""SeatName"":""A3"",""CustomerID"":""KH01"",""PaymentType"":""Chưa được Đặt"",""Price"":85000.0,""Status"":0}]";
                com.CommandText = "SELECT * FROM FUNC_GetSoldByMoMo(@json, 'KH01')";
                com.Parameters.Add("@json", SqlDbType.NVarChar).Value = json;
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    payments.Add(new Payment()
                    {
                        MovieID = dr["id"].ToString()
                    ,
                        MovieName = dr["TenPhim"].ToString()
                    ,
                        Date = dr["NgayChieu"].ToString()
                    ,
                        ShowTime = dr["SuatChieu"].ToString()
                    ,
                        CusID = dr["HoTen"].ToString()
                    ,
                        SeatID = dr["MaGhe"].ToString()
                    ,
                        Price = dr["TienBanVe"].ToString()
                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public IActionResult ReturnUrl()
        //{
        //    FetchTable();
        //    return View(payments);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}