# RBS

IN DEVELOPMENT HELL!!!!

--- Overview
The purpose is to create a simple room booking system for use in a factory. The dashboard will allow the users to select from two distinct areas in the factory. Each area is represented buy it's own image map. Each image map contains shapes highlighted over the name of each room. Once these map areas have been selected by the user, a view is created with a calendar designed with html5 and angularjs.

The calendar will link to outlook with office 365 api and Azure AD

-- Model
- Booking.cs
Provides details re. information to book rooms. Will link into Office 365 Outlook API.
Booking info found in Bookings.mdf

- rooms.cs
Passes room location information to the room view. Room info found in Rooms.mdf

-- Controllers
- BookingsConroller.cs
Passes user information from the calendar to the bookings model

- HomeController.cs
Directs user views of each page

- roomsController.cs
Passes information from the rooms.mdf file to the Home view for each location in the factory

-- Views
- Home
Dashboard/ Locations in factory

- Rooms
Calendar
