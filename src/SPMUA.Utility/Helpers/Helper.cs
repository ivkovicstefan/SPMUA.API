﻿using SPMUA.Model.Commons.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SPMUA.Utility.Helpers
{
    public static class Helper
    {
        public static TimeOnly RoundToNextHour(TimeOnly time)
        {
            int deltaTimeInMinutes = 0 - time.Minute;

            if (deltaTimeInMinutes != 0)
            {
                time = time.AddMinutes(deltaTimeInMinutes).AddHours(1);
            }

            return time;
        }

        public static TimeInterval CreateAppointmentTimeInterval(TimeOnly time, int duration, bool isRoundToNextHourEnabled = true)
        {
            // Flatten the time 
            time = new TimeOnly(time.Hour, time.Minute, 0);

            return new TimeInterval(time, isRoundToNextHourEnabled ? RoundToNextHour(time.AddMinutes(duration)) 
                                                                   : time.AddMinutes(duration));
        }

        public static string ReplaceTemplateWithParamData<T> (string template, T paramData) 
        {
            Type dataType = typeof (T);

            PropertyInfo[] properties = dataType.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                string propertyName = property.Name;
                string propertyValue = property.GetValue(paramData)?.ToString();

                string placeholder = $"{{{{{propertyName}}}}}";
                template = template.Replace(placeholder, propertyValue);
            }

            return template;
        }

        public static int ToNormalizedWeekDayIndex(int weekDayIndex)
        {
            return weekDayIndex == 0 ? 7 : weekDayIndex;
        }
    }
}
