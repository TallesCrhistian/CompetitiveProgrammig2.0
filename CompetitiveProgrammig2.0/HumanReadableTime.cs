namespace CompetitiveProgrammig2
{
    public class HumanReadableTime
    {
        public string GetReadableTime(int seconds)
        {
            int hours = 0;
            int minutes = 0;
            string result = string.Empty;

            if (seconds == 3600)
            {
                hours = 1;
            }

            else
            {
                hours = seconds / 3600;
            }

            if (seconds == 60)
            {
                minutes = 1;
            }

            else
            {
                minutes = seconds / 60;
            }

            if (hours > 0)
            {
                if (hours > 9 && hours < 99)
                {
                    result = hours.ToString() + ":";
                }

                else if (hours >= 99)
                {
                    result = "99:";
                }

                else
                {
                    result = "0" + hours.ToString() + ":";
                }
            }

            else result = "00:";

            minutes -= hours * 60;

            if (minutes > 0)
            {
                if (minutes > 9 && minutes < 60)
                {
                    result += minutes.ToString() + ":";
                }

                else if (minutes > 60)
                {
                    result += "59:";
                }

                else
                {
                    result += "0" + minutes.ToString() + ":";
                }
            }

            else result += "00:";

            seconds -= minutes * 60;

            if (seconds > 0)
            {
                if (seconds > 9 && seconds < 60)
                {
                    result += seconds.ToString();
                }

                else if (seconds > 60)
                {
                    result += "59";
                }

                else
                {
                    result += "0" + seconds.ToString();
                }
            }

            else result += "00";

            return result;
        }
    }
}
