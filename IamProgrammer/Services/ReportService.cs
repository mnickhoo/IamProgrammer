using IamProgrammer.Models;
using IdentitySample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IamProgrammer.Services
{
    public class ReportService
    {
        public ReportService()
        {
            Supporters = db.Supporters.ToList();
        }
        ApplicationDbContext db = new ApplicationDbContext();
        IEnumerable<supporterModel> Supporters; 
        //Get Count of supporter 
        public int GetCountOfSupporter()
        {
            try
            {
                int Count = Supporters.Count();
                return Count;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool ReportProcessing()
        {
            try
            {
                var CountSupporter = this.GetCountOfSupporter();
                var IsWorking = this.GetSupporterIsWorking();
                var ReadyForHire = this.GetSupporterReadyForHire();
                var female = this.GetFemaleCount();
                var male = this.GetMaleCount();
                ReportModel report = new ReportModel()
                {
                    CountSupporter = CountSupporter, 
                    Date = DateTime.Now  , 
                    IsWorking  = IsWorking , 
                    ReadyForHire = ReadyForHire , 
                    Female = female , 
                    Male = male 
                };
                db.Reports.Add(report);
                db.SaveChanges();
                return true; 
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        //Get Count of Supporter enroll today 

        //Get Count Of Developer now is working 
        public int GetSupporterIsWorking()
        {
            try
            {
                var count = Supporters.Where(s => s.IsWorking == true).ToList().Count;
                return count;
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        //get Count of developer ready for hire 
        public int GetSupporterReadyForHire()
        {
            try
            {
                var count = Supporters.Where(s => s.ReadyForHire == true).ToList().Count;
                return count;
            }
            catch (Exception e)
            {
                throw e;
            }
         
        }

        public int GetFemaleCount()
        {
            try
            {
                var count = Supporters.Where(s => s.Gender == false).ToList().Count;
                return count;
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public int GetMaleCount()
        {
            try
            {
                var count = Supporters.Where(s => s.Gender == true).ToList().Count;
                return count;
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        //get Last generate Report 
        public ReportModel GetLateastReport()
        {
            try
            {
                var latestReport = db.Reports.ToList().LastOrDefault();
                return latestReport; 
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}