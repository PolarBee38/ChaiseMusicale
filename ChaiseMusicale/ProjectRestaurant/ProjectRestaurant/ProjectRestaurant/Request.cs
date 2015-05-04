using System;

namespace ChaiseMusicale
{
	public class Request
	{
		private string _name; 
		private int _size; 
		private int _timeSlot; 
		private Boolean _status; 
		public Request (string name, int size, int timeSlot)
		{
			_name = name;
			_size = size; 
			_timeSlot = timeSlot; 
			_status = false; 
		}

		public int getTimeSlot() 
		{
			return _timeSlot;
		}

		public int getSize()
		{
			return _size; 
		}

		public Boolean getStatus()
		{
			return _status; 
		}

		public void assignRequest()
		{
			_status = true; 
		}

		public Boolean reduceTurnCost()
		{
			if (this._timeSlot % 4 == 1)
				return false;
			else
				return true; 
		}

		public Boolean fitExactly (Table table) 
		{
			if (table.available (this) && this.getSize () == table.getSize () && !this.reduceTurnCost() )
				return true;
			else
				return false; 
		}
	}
}

