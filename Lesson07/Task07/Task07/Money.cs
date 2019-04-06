using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
	public class Money
	{
		private int _hryvnia;
		private int _coins;

		public Money(int hrivn,int coins)
		{
            Hrivnia = hrivn;
            Coins = coins;
		}
        public Money()
        {

        }
        public override bool Equals(object obj)
		{
			return this.ToString() == obj.ToString();
		}
		public override string ToString()
		{
			return $"Hrivnas: {Hrivnia} Coins: {Coins}";
		}
		public void ChangeCoinsToHrivnas(int value)
		{

			Hrivnia += value / 100;
			_coins += value - ((value / 100) * 100);
		}

		public int Hrivnia
		{
			get
			{
				return _hryvnia;
			}
			set
			{
				if (value < 0)
				{
					throw new Bankrupt("U are bankrupt");
				}

				_hryvnia = value;
			}
		}
		
		public int Coins
		{
			get
			{
				//if (_coins >= 100)
				//{
				//	ChangeCoinsToHrivnas(_coins);
				//}
				return _coins;
			}
			set
			{
				if (value < 0)
				{
					throw new Bankrupt("U are bankrupt");
				}
				else if (value >= 100)
				{
					ChangeCoinsToHrivnas(value);
				}
				else
				{
					_coins = value;
				}
			}
		}
		public static Money operator +(Money m1,Money m2)
		{
			return new Money { Hrivnia = m1.Hrivnia + m2.Hrivnia, Coins = m1.Coins + m2.Coins };

		}
		public static Money operator -(Money m1, Money m2)
		{
			return new Money { Hrivnia = m1.Hrivnia - m2.Hrivnia,Coins = m1.Coins - m2.Coins };
		}

		public static Money operator /(Money m1, int value)
		{

			return new Money { Hrivnia = m1.Hrivnia / value,Coins = m1.Coins / value };
		}
		public static Money operator *(Money m1, int value)
		{
			return new Money { Hrivnia = m1.Hrivnia * value, Coins = m1.Coins * value };
		}
		public static Money operator++(Money m1)
		{
			return new Money {  Hrivnia = m1.Hrivnia, Coins = m1.Coins + 1 };
		}
		public static Money operator --(Money m1)
		{
			return new Money { Hrivnia = m1.Hrivnia,Coins = m1.Coins - 1  };
		}
		public static bool operator >(Money m1, Money m2)
		{
			if (m1.Hrivnia > m2.Hrivnia)
			{
				return true;
			}
			else if (m1.Hrivnia < m2.Hrivnia)
			{
				return false;
			}
			else if((m1.Hrivnia == m2.Hrivnia)&&(m1.Coins>m2.Coins))
			{
				return true;
			}
			else 
			{
				return false;
			}
		}
		public static bool operator <(Money m1, Money m2)
		{
			if (m1.Hrivnia > m2.Hrivnia)
			{
				return false;
			}
			else if (m1.Hrivnia < m2.Hrivnia)
			{
				return true;
			}
			else if ((m1.Hrivnia == m2.Hrivnia) && (m1.Coins > m2.Coins))
			{
				return false;
			}
			else
			{
				return true;
			}
		}
		public static bool operator ==(Money m1, Money m2)
		{
			return m1.Equals(m2);
		}
		public static bool operator !=(Money m1, Money m2)
		{
			return (!m1.Equals(m2));
		}
	}
}
