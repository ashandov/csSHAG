using System;
using System.Runtime.Serialization;

namespace Task09
{
    [Serializable]
    public class Bill:ISerializable
    {
      
        public static bool FormatingCalculated = false;
        private decimal _totalSum;
        private decimal _fine;
        private decimal _withoutFineSum;

        public Bill(decimal dayPayment,decimal finePrice)
        {
            FinePrice = finePrice;
            DailyPrice = dayPayment;
            Days = 1;
            DelayDays = 0;
            
        }
        private Bill(SerializationInfo info,StreamingContext context)
        {
            DailyPrice = info.GetDecimal("DailyPrice");
            Days = info.GetInt32("Days");
            DelayDays = info.GetInt32("DelayDays");
            //if (FormatingCalculated)
            //{
            //    Fine = info.GetDecimal("Fine");
            //    WithoutFineSum = info.GetDecimal("WithoutFineSum");
            //    TotalSum = info.GetDecimal("TotalSum");
            //}

        }

        public decimal DailyPrice { get; set; }
        public int Days { get; set; }
        public decimal FinePrice { get; set; }
        public decimal Fine
        {
            get
            {
                return FinePrice * DelayDays;
            }
           
        }
        public int DelayDays { get; set; }
        public decimal WithoutFineSum
        {
            get
            {
                return DailyPrice * Days;
            }
        }

        public decimal TotalSum
        {
            get
            {
                return ((DailyPrice * Days) + (Fine * DelayDays));
            }
        }
        private void SetCalculatedProp()
        {

        }
         void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("DailyPrice", DailyPrice);
            info.AddValue("Days", Days);
            info.AddValue("DelayDays", DelayDays);
            if (FormatingCalculated)
            {
                info.AddValue("Fine", Fine);
                info.AddValue("WithoutFineSum", WithoutFineSum);
                info.AddValue("TotalSum", TotalSum);
            }

        }



    }
}

