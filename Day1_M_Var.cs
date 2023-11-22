review1.cs
public bool IsShopOpen(string day)
{
    if (!string.IsNullOrEmpty(day))
    {
        day = day.ToLower();
        if (day == "friday")
        {
            return true;
        }
        else if (day == "saturday")
        {
            return true;
        }
        else if (day == "sunday")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}

//solution
var openingDays=new[]{ "friday","saturday", "sunday"}
return openingDays.Any(d=>decimal==days.ToLower());
-------------------------------------------------------------------------------------------------------------------------------------------------
  review3.cs
  public long Fibonacci(int n)
{
    if (n < 50)
    {
      if (n != 0)
        {
            if (n != 1)
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 0;
        }
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}
//solution
public long Fibonacci(int n)
{
    if (n < 50 )
    {
        if (n != 0|| n !=1)
        {     
            return Fibonacci(n - 1) + Fibonacci(n - 2);}    
        else
        {
            return n;
        }       
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}
--------------------------------------------------------------------------------------------------------------------------------------------------
  review4.cs
  var l = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < l.Count(); i++)
{
    var li = l[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(li);
}
//solution
var location = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < location.Count(); i++)
{
    var list = location[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(list);
}
 --------------------------------------------------------------------------------------------------------------------------------------------------
 review5.cs
if (userRole == 8) // Check if Admin 
{
    
}

//solution
const string ADMIN_ROLE=adminRole
if (userRole == adminRole) // Check if Admin 
  {
      
  }
 --------------------------------------------------------------------------------------------------------------------------------------------------
 review6.cs
 public class Car
{
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public string CarColor { get; set; }

    //...
}


//solution
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }

    //...
}
 --------------------------------------------------------------------------------------------------------------------------------------------------
review7.cs
var ymdstr = DateTime.UtcNow.ToString("MMMM dd, yyyy");
//solution
var date = DateTime.UtcNow.ToString("MMMM dd, yyyy");

 --------------------------------------------------------------------------------------------------------------------------------------------------

review9.cs
   public void CreateMicrobrewery(string name = null)
{
    var breweryName = !string.IsNullOrEmpty(name) ? name : "Hipster Brew Co.";
    // ...
}

//solutin
   public void CreateMicrobrewery(string breweryName = "Hipster Brew Co.")
{
    
}
   
