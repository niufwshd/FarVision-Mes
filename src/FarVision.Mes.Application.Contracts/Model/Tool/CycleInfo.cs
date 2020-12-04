using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using YueMES.Base.Config;
using YueMES.Base.Dal;
using YueMES.Base.Utils;

namespace WebMES.Model.Tool.CycleInfo
{
    [Serializable]
    public class Periods : ICloneable
    {
        public string Name = "";
        public Frequency Frequency { get; set; }      //周期
        public int Interval = 1;                  //间隔
        public List<Ban> BanS;                    //班别

        public DateTime StartDate = DateTime.Now.Date;
        public DateTime EndDate = DateTime.Now.Date;
        public bool HasEndDate = true;
        public bool Enabled = true;
        public string Rem = "";
        public Periods(Frequency frequency, int interval)
        {
            Frequency = frequency;
            Interval = interval;
            string sql = @"SELECT BAN_NO,NAME FROM MF_BAN";
            BooleanValue<DataTable> bv = DAO.Default.GetDataTable(sql);
            if (bv.Success && bv.Value != null)
            {
                if (BanS == null)
                {
                    BanS = new List<Ban>();
                    foreach (DataRow row in bv.Value.Rows)
                    {
                        BanS.Add(new Ban(row["BAN_NO"].ToString(), row["NAME"].ToString(), false));
                    }
                }
            }
        }
        public Periods():this(Frequency.Day,1)
        {
            
        }
        public Periods(Periods periods)
        {
            this.Name = periods.Name;
            this.BanS = periods.BanS;
            this.StartDate = periods.StartDate;
            this.EndDate = periods.EndDate;
            this.HasEndDate = periods.HasEndDate;
        }

        public virtual byte[] ToBytes()
        {
            BooleanValue<byte[]> bv = StoreBase.GetBytes(this, true, "");
            if (bv.Success)
                return bv.Value;
            return null;
        }

        public virtual Periods ToPeriods(byte[] bytes)
        {
            BooleanValue<Periods> bv = StoreBase.GetObjectBV<Periods>(bytes, true, "");
            if (bv.Success)
                return bv.Value;
            return null;
        }




        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    public static class PeriodsFactory
    {
        public static Periods CreatePeriods(Frequency f, int interval)
        {
            Periods pd = null;
            switch (f)
            {
                case Frequency.Hour:
                    pd = new HourPeriods(interval);
                    break;
                case Frequency.Day:
                    pd = new DayPeriods(interval);
                    break;
                case Frequency.Week:
                    pd = new WeekPeriods(interval);
                    break;
                case Frequency.Month:
                    pd = new MonthPeriods(interval);
                    break;
                case Frequency.Times:
                    pd = new TimePeriods(interval);
                    break;
            }
            return pd;

        }
    }
    [Serializable]
    public enum Frequency
    {
        Hour = 0,
        Day = 1,
        Week = 2,
        Month = 3,
        Times = 4
    }
    public enum TimeCalType
    {
        /// <summary>
        /// 自然时间
        /// </summary>
        NatureTime = 0,
        /// <summary>
        /// 设备累计生产时间
        /// </summary>
        AccPdTime = 1

    }

    [Serializable]
    public class TimePeriods : Periods
    {
        public TimePeriods(int interval)
            : base(Frequency.Times, interval)
        { }

        public TimePeriods(Periods periods)
            : base(periods)
        {
            this.Frequency = Frequency.Times;
        }
    }
    [Serializable]
    public class Ban
    {
        public string BAN_NO;
        public string NAME;
        public bool IsCheck;
        public Ban(string banno, string name, bool isCheck)
        {
            BAN_NO = banno;
            NAME = name;
            IsCheck = isCheck;
        }

    }
    [Serializable]
    public class HourPeriods : Periods
    {
        // public bool IsNatureTime = false;

        public TimeCalType TimeCalType = TimeCalType.AccPdTime;
        public HourPeriods(int interval)
            : base(Frequency.Hour, interval)
        { }

        public HourPeriods(Periods periods)
            : base(periods)
        {
            this.Frequency = Frequency.Hour;
        }
    }

    [Serializable]
    public class DayPeriods : Periods
    {
        public DayPeriods(int interval)
            : base(Frequency.Day, interval)
        { }

        public DayPeriods(Periods periods)
            : base(periods)
        {
            this.Frequency = Frequency.Day;
        }
    }

    [Serializable]
    public class WeekPeriods : Periods
    {
        public List<int> WeekDays = null;

        public WeekPeriods(int interval)
            : base(Frequency.Week, interval)
        {
            WeekDays = new List<int>();
        }
        public WeekPeriods(Periods periods)
            : base(periods)
        {
            this.Frequency = Frequency.Week;
        }

    }
    [Serializable]
    public class MonthPeriods : Periods
    {
        public int day = 1;
        public int MonthDay = 1;
        public bool IsAssignDay = true;
        public int WeekDay = 1;
        public int WeekIndex = 1;
        public MonthPeriods(int interval)
            : base(Frequency.Month, interval)
        {

        }
        public MonthPeriods(Periods periods)
            : base(periods)
        {
            this.Frequency = Frequency.Month;
        }

    }

    [Serializable]
    public class JHCycleInfo
    {
        public string ExcuteType = "";
        public bool IsEnable;
        public List<Ban> Ban;
        public DateTime StartTime;
        public DateTime EndTime;
        public string Abstract = "";
        public string JHName = "";//计划名称
        public int HourN;
        public string HourMethod = "";//'按设备累计生产时间计算',
        public int DayN;
        public int WeekN;
        public List<bool> WeekCheck;
        public string MonthMethod = "";//'方式一',
        public int MonthOneN1;
        public int MonthOneN2;
        public int MonthTwoN;
        public string MonthTwoItem1 = "";//'第一个',
        public string MonthTwoItem2 = "";//'星期一',
    }


}
