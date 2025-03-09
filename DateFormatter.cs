Console.Write("Enter a month: ");
int month = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a day: ");
int day = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a year: ");
int year = Convert.ToInt32(Console.ReadLine());

string monthwrd;

switch (month)
{
    case 1:
        monthwrd = "January";
        break;
    case 2:
        monthwrd = "February";
        break;
    case 3:
        monthwrd = "March";
        break;
    case 4:
        monthwrd = "April";
        break;
    case 5:
        monthwrd = "May";
        break;
    case 6:
        monthwrd = "June";
        break;
    case 7:
        monthwrd = "July";
        break;
    case 8:
        monthwrd = "August";
        break;
    case 9:
        monthwrd = "September";
        break;
    case 10:
        monthwrd = "October";
        break;
    case 11:
        monthwrd = "November";
        break;
    case 12:
        monthwrd = "December";
        break;
    default:
        monthwrd = "Invalid month";
        break;
}

if(monthwrd == "Invalid month")
{
    Console.WriteLine("Invalid month");
}
else
{
    Console.WriteLine("The date is {0} {1}, {2}", monthwrd, day, year);
}
