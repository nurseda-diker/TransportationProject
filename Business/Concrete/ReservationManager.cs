using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReservationManager:IReservationService
    {
        IReservationDal _reservationDal;
        public ReservationManager(IReservationDal reservationDal)
        {
           _reservationDal = reservationDal;
        }

        public List<Reservation> GetAll()
        {
            return _reservationDal.GetAll();
        }
    }
}
