using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourReservationApi.Domain.Entities;

namespace TourReservationApi.Application.Abstractions
{
    public interface IRegisterService
    {
        List<Register> GetRegisters();
    }
}
