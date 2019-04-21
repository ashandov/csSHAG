using System;
namespace UserAttribute
{
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    public class CoderAttribute:Attribute
    {
        private string _name = "Yuriy";
        private DateTime _date = DateTime.Now;

        public CoderAttribute()
        {
        }
        public CoderAttribute(string name,string date)
        {
            try
            {
                _name = name;
                _date = Convert.ToDateTime(date);
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public override string ToString()
        {
            return $"Coder: {_name}, Date: {_date}";
        }
    }
}
