# Movie-Ticket-Booking
A desktop specialized application designed specifically for POS Machine provides seamless ticket booking experiences and information management model through subtle, easy-to-grasp features

## Features
### Sale Page
- Movie Selection: Movie, Show Date, Show Time, Screen Type
- Remaining Seats and Cinema Status presentation
- Seat Selection with various configurations for customers: Seat Type, Error Notification when occupied seat is chosen, multiple seats selection
- Membership Reward Point Accumulation Program based on Customer Name and ID
- Point - Ticket Conversion Program
- Notional Price Presentation
- Payment Price Presentation
- Diverse Payment options: Cash, MoMo Offline, MoMo Online
- Payment status email confirmation
### Manager Page
- Revenue statistics with attribute configurations
- Revenue Export capability with support of several formats
- Movie Data configurations, initialization with logical, coherent constraints
- User account management layout: staff account sign-up, credentials reset
- Customer membership management layout: customer membership sign-up, email confirmation, point modification, membership erasure
- Network, Database and VPS Database Connection Initialization with personal credential attributes
## Deployment Steps
- Unzip the download package by choosing “ Extract to … “ option with your personal, favored file archiver utility ( either Winrar or 7Zip works best in this instances )
- Publish the project through IIS ( Internet Information Service ) Windows server under the host name of “gateway.momo.com”, “127.0.0.1“ host IP and “80” for host port
- Download and paste the license file ( either trial or paid is appropriate ) from dotnetbrowser API to the root folder of the project
- Download dotnetbrowser and dotnetbrowser.winforms from nuget package manager
- Modify the dotnetbrowser license file attribute to “Embedded resource” through your preferred IDE
- Run the SQL script for database initialization which could be found in database folder from downloaded package
- Start the application with the following default username and password ( Username: admin - Password: admin )
- Configure the network and database connection in manager page with hinted information below
<p><pre> Server Name: [ your PC or VPS name ] </pre></p>
<p><pre> Database Name: [ database name ] </pre></p>
<p><pre> Username: [ SQL Server login username credential ] </pre></p>
<p><pre> Password: [ SQL Server password for user property ] </pre></p>

- Enjoy the seamless experiences with the massively robust features 
