﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniVoting.Data.Implementations;
using UniVoting.Model;

namespace UniVoting.Services
{
	public class ElectionConfigurationService
	{
		#region Voters
		public static int AddVoters(List<Voter> voters)
		{
			try
			{
				return new ElectionBaseRepository().InsertBulk(voters);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		public static Task<Voter> LoginVoter(Voter voter)
		{
			try
			{
				return new ElectionBaseRepository().Login(voter);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		#endregion

		#region Election
		public static  Task<Setting> ConfigureElection(int id)
		{
			try
			{
				return   new ElectionBaseRepository().GetByIdAsync<Setting>(id);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		public static async void NewElection(Setting setting)
		{
			try
			{
				await new ElectionBaseRepository().Insert(setting);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		#endregion
		#region Candidate
		public async void AddCandidate(Candidate candidate)
		{
			try
			{
				await new ElectionBaseRepository().Insert(candidate);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		public async void SaveComissioner(Comissioner comissioner)
		{
			if (comissioner.Id==0)
			{
				try
				{
					await new ElectionBaseRepository().Insert(comissioner);

				}
				catch (Exception e)
				{
					Console.WriteLine(e);
					throw;
				}
			}
			else
			{
				try
				{
					await new ElectionBaseRepository().Update(comissioner);

				}
				catch (Exception e)
				{
					Console.WriteLine(e);
					throw;
				}
			}
			
		}
	   
		public  Task<IEnumerable<Candidate>> GetAllCandidates()
		{
			try
			{
				return new ElectionBaseRepository().GetAllAsync<Candidate>();
				
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		public Task<IEnumerable<Candidate>> GetAllCandidatesAsync()
		{
			try
			{
				return new ElectionBaseRepository().GetAllAsync<Candidate>();

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		public static Task<Candidate> SaveCandidate(Candidate candidate)
		{
			try
			{
				if (candidate.Id == 0)
				{
					return new ElectionBaseRepository().Insert(candidate);
				}
				else
				{
					return new ElectionBaseRepository().Update(candidate);

				}
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
			
		}
	   
		public void RemoveCandidate(Candidate candidate)
		{
			try
			{
				new ElectionBaseRepository().Delete(candidate);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		#endregion
		#region Position
		public static Task<Position> AddPosition(Position position)
		{
			try
			{
				var data = new ElectionBaseRepository().Insert(position);
				return data;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		 
		}
		public static Position GetPosition(int positionid)
		{
			try
			{
				return new ElectionBaseRepository().GetById<Position>(positionid);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		   
		}
		public static IEnumerable<Position> GetAllPositions()
		{
			try
			{
				return new ElectionBaseRepository().GetPositionsWithDetails();

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		public static IEnumerable<Position> GetPositionsSlim()
		{
			try
			{
				return new ElectionBaseRepository().GetAll<Position>();

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		public Task<IEnumerable<Position>> GetAllPositionsAsync()
		{
			try
			{
				return new ElectionBaseRepository().GetAllAsync<Position>();

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		public static async void UpdatePosition(Position position)
		{
			try
			{
				await new ElectionBaseRepository().Update(position);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
	   
		public static void RemovePosition(Position position)
		{
			try
			{
				new ElectionBaseRepository().Delete(position);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		#endregion   
		#region User
		public async void AddUser(User user)
		{
			try
			{
				await new ElectionBaseRepository().Insert(user);

			}
			catch (Exception e)
			{
				Console.WriteLine(e);
				throw;
			}
		}
		public static async Task<Comissioner> Login(Comissioner comissioner)
		{
			Comissioner user=new Comissioner();
			if (comissioner.IsChairman)
			{
				try
				{ user= await new ElectionBaseRepository().LoginChairman(comissioner);}
				catch (Exception e)
				{
					Console.WriteLine(e);
					throw;
				}
			}
			else if (comissioner.IsPresident)
			{
				try
				{ user= await new ElectionBaseRepository().LoginPresident(comissioner);}
				catch (Exception e)
				{
					Console.WriteLine(e);
					throw;
				}
			}else if (comissioner.IsAdmin)
			{
				try
				{ user= await new ElectionBaseRepository().LoginAdmin(comissioner);}
				catch (Exception e)
				{
					Console.WriteLine(e);
					throw;
				}
			}
			else
			{
				try
				{  user= await new ElectionBaseRepository().LoginPresident(comissioner);}
				catch (Exception e)
				{
					Console.WriteLine(e);
					throw;
				}
			}
			
			return user;
		}
		#endregion
		
	}
}