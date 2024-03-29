using System;
namespace SampleDesignPattern.FacadePattern{

    //facade use many subsystem
    public class BookingFacade{
        private EmployeeAvailable _employeeAvailable = new EmployeeAvailable();
        private TimeBookingAvailable _timeBookingAvailable = new TimeBookingAvailable();

        public bool IsCanBook(Customer customer, string employeeName, string timeBooking){
            bool isCanBook = true;
            if(!_employeeAvailable.IsEmployeeAvailable(employeeName))
                isCanBook = false;
            if(!_timeBookingAvailable.IsTimeBookingAvailable(timeBooking))
                isCanBook = false;
            return isCanBook;
        }
    }
}