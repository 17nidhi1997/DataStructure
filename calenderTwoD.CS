using System;

namespace calenderTwoD
{
    class Program
    {
		public bool isLeapYear;
		static void Main(string[] args)
        {
			int month, year;

			bool isLeapYears;

			int days, day;

			int[] daysPerYear = { 31, 28, 30, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

			Console.WriteLine("Enter month");

			month = Convert.ToInt32(Console.ReadLine());
			if (month > 0 && month <= 12)
			{

				Console.WriteLine("Enter Year");

				year = Convert.ToInt32(Console.ReadLine());

				if (year > 1582 && year < 9999)
				{
					bool isLeapYear(int year)
					{

						if (year % 4 == 0 || year % 400 == 0 && year % 100 != 0)

							return true;

						else

							return false;

					}
					isLeapYears = isLeapYear(year);

					if (isLeapYears && month == 2)
					{


						days = 29;


						day = calculateDayOfWeek(1, month, year);


						printCalendar(day, days);



					}
					else
					{

						days = daysPerYear[month - 1];

						day = calculateDayOfWeek(1, month, year);

						printCalendar(day, days);

					}


				}
				else

					Console.WriteLine("please enter valid year");

			}
			else

				Console.WriteLine("Please enter valid month");

		}
		
		

		public static int calculateDayOfWeek(int day, int month, int year)
		{

			int y1, x, m, d1;

			y1 = year - (14 - month) / 12;

			x = y1 + (y1 / 4) - (y1 / 100) + (y1 / 400);

			m = month + 12 * ((14 - month) / 12) - 2;

			d1 = (day + x + 31 * m / 12) % 7;

			return d1;

		}

		public static void printCalendar(int day, int days)
		{

			Console.WriteLine("SUN MON TUE WED THU FRI SAT");

			String[,] cal = new String[6,7];

			int temp;

			switch (day)
			{

				case 0:

					temp = 1;

					for (int i = 0; i < 6; i++)
					{

						for (int j = 0; j < 7; j++)
						{

							if (temp <= 9)
							{

								cal[i,j] = temp + "   ";

							}
							else
							{

								cal[i,j] = temp + "  ";

							}

							temp++;

							if (temp == days + 1)
							{

								break;

							}

						}

						if (temp == days + 1)
						{

							break;

						}

					}

					break;

				case 1:

					temp = 1;


					for (int i = 0; i < 6; i++)
					{

						for (int j = 0; j < 7; j++)
						{

							if (i == 0 && j == 0)
							{

								cal[i,j] = "    ";

							}
							else
							{

								if (i <= 9)
								{

									cal[i,j] = temp + "   ";

								}
								else
								{

									cal[i,j] = temp + "  ";

								}

								temp++;

							}

							if (temp == days + 1)
							{

								break;

							}

						}

						if (temp == days + 1)
						{

							break;

						}

					}

					break;

				case 2:

					temp = 1;


					for (int i = 0; i < 6; i++)
					{

						for (int j = 0; j < 7; j++)
						{

							if (i == 0 && j == 0 || i == 0 && j == 1)
							{

								cal[i,j] = "    ";

							}
							else
							{

								if (temp <= 9)
								{

									cal[i,j] = temp + "   ";

								}
								else
								{

									cal[i,j] = temp + "  ";

								}

								temp++;

							}

							if (temp == days + 1)
							{

								break;

							}


						}

						if (temp == days + 1)
						{

							break;

						}


					}

					break;

				case 3:

					temp = 1;


					for (int i = 0; i < 6; i++)
					{

						for (int j = 0; j < 7; j++)
						{

							if (i == 0 && j <= 0 || i == 0 && j >= 2)
							{

								cal[i,j] = "    ";

							}
							else
							{

								if (temp <= 9)
								{

									cal[i,j] = temp + "   ";

								}
								else
								{

									cal[i,j] = temp + "  ";

								}

								temp++;

							}

							if (temp == days + 1)
							{

								break;

							}


						}

						if (temp == days + 1)
						{

							break;

						}

					}

					break;

				case 4:


					temp = 1;


					for (int i = 0; i < 6; i++)
					{

						for (int j = 0; j < 7; j++)
						{

							if (i == 0 && j <= 0 || i == 0 && j >= 3)
							{

								cal[i,j] = "    ";

							}
							else
							{

								if (temp <= 9)
								{

									cal[i,j] = temp + "   ";

								}
								else
								{

									cal[i,j] = temp + "  ";

								}

								temp++;

							}

							if (temp == days + 1)
							{

								break;

							}


						}

						if (temp == days + 1)
						{

							break;

						}

					}

					break;

				case 5:


					temp = 1;


					for (int i = 0; i < 6; i++)
					{

						for (int j = 0; j < 7; j++)
						{

							if (i == 0 && j <= 0 || i == 0 && j >= 4)
							{

								cal[i,j] = "    ";

							}
							else
							{

								if (temp <= 9)
								{

									cal[i,j] = temp + "   ";

								}
								else
								{

									cal[i,j] = temp + "  ";

								}

								temp++;

							}

							if (temp == days + 1)
							{

								break;

							}


						}

						if (temp == days + 1)
						{

							break;

						}

					}

					break;

				case 6:


					temp = 1;


					for (int i = 0; i < 6; i++)
					{

						for (int j = 0; j < 7; j++)
						{

							if (i == 0 && j <= 0 || i == 0 && j >= 5)
							{

								cal[i,j] = "    ";

							}
							else
							{

								if (temp <= 9)
								{

									cal[i,j] = temp + "   ";

								}
								else
								{

									cal[i,j] = temp + "  ";

								}

								temp++;

							}

							if (temp == days + 1)
							{

								break;

							}


						}

						if (temp == days + 1)
						{

							break;

						}

					}

					break;

			}

			for (int i = 0; i < 6; i++)
			{

				for (int j = 0; j < 7; j++)
				{

					if (cal[i,j] == null)
						break;

					Console.Write(cal[i,j]);


				}

				if (i== null)

					break;

				Console.WriteLine();

			}
		}
	}
}
