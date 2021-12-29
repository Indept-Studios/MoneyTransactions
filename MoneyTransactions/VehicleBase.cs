using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyTransactions
{
    public class VehicleBase
    {
        enum VehicleTypes
        {
            Kleintransporter,
            Gliederzug,
            Sattelzug,
            Personenkraftwagen
        }

        public float Tank { get; }
        public float TransportCapacity { get; }
        public float DistanceDriven { get; }
        public int MaintenanceCondition { get; }
        public bool IsInsured { get; }
        public Insurence Insurence { get; }
    }
}
