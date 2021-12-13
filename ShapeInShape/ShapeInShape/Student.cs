using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeInShape
{
	public class Student
	{
		private string _id;
		private static string _log;

		public Student(string id)
		{
			_id = id;
		}

		public string ID
		{
			get 
			{
				double equalOrHigher;
				equalOrHigher = Convert.ToDouble(_id);
				if ((equalOrHigher <= 20190) || (equalOrHigher >= 20220))
				{
					throw new Exception("Class ID numbers range from 20191 - 20219");
				}
				_log += DateTime.Now.ToString() + " - ID added: " + _id + "\n";
				return "*RESTRICTED*";
			}
			set
			{
				_id = value;
			}
		}

		public string Log
		{
			get 
			{ 
				return _log; 
			}
		}
	}
}
