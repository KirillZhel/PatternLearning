using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPatterns
{
	public interface IChair
	{
		public bool HasLegs { get; set; }
		
		public bool SitOn();
	}

	public interface ITable
	{
		public void PutOn(string thing);
	}

	public interface IFurnitureFactory
	{
		public IChair CreateChair();
		public ITable CreateCoffeTable();
	}
}
