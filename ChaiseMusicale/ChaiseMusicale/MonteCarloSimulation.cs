/*using System;

namespace ChaiseMusicale
{
	public class MonteCarloSimulation
	{
		private Request _request; 
		//public Simulation (){}

		public int MonteCarlo(int numberOfIteration,int maxSize, int maxRequest, int maxTimeSlot, Table[] tableList)
		{
			
			double meanSeatCount = 0; 
			int simulatedSeatCount = 0; 
			for (int i = 1; i <= numberOfIteration; i++)
			{
				Request[] futureRequest = futureSimulation (maxSize, maxRequest, maxTimeSlot); 
				int futureSeat = futureSeatCount (tableList, futureRequest); 
				simulatedSeatCount = simulatedSeatCount + futureSeat; 
			}
			meanSeatCount = simulatedSeatCount / numberOfIteration; 
			return meanSeatCount;
		}

		public Request[] futureSimulation(int maxSize, int maxRequest, int maxTimeSlot)
		{
			Random rnd = new Random (); 
			int groupSize = 0 ; 
			int timeSlot = 0; 
			Request[] requestSimulation = new Request[maxRequest]; 
			for (int i = 0; i < maxRequest; i++)
			{
				groupSize = rnd.Next(1, maxSize+1); 
				timeSlot = rnd.Next(1, maxTimeSlot+1-3);
				requestSimulation[i] = new Request("aaa", groupSize, timeSlot); 
			}

			return requestSimulation; 
		}

		public Boolean available(Request _request) // class Table
		{
			Boolean available = true;
			int initialSlot = _request.getTimeSlot(); 
			for (int i = initialSlot; i < initialSlot + 4; i++)
			{
				if (if this.state[i] % 10 == 1)
					continue;
				else 
				{
					available = false; 
					break; 
				}
			}
			return available; 
		}



		public int futureSeatCount(Table[] tableList, Request[] futureRequest)
		{
			int futureSeatCount = 0; 

			//first pass
			foreach (Request request in futureRequest)
			{
				foreach (Table table in tableList)
				{
					if (request.fitExactly(table))
					{
						// assign table to request 
						// update table status 
						request.assignRequest(); 
						futureSeatCount += request.getSize; 
						break; 
					}
				}
			}

			//second pass
			foreach (Request request in futureRequest)
			{
				foreach (Table table in tableList) 
				{
					if (!request.getStatus && table.available(request) && table.getSize >= request.getSize) 
					{
						// assign table to request 
						// update table status 
						request.assignRequest(); 
						futureSeatCount += request.getSize;
						break; 	
					}
				}
			}
			return futureSeatCount; 
		}
	}
}*/