using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UITests;

public class AutomatedUITests : IDisposable
{
    private readonly IWebDriver _driver;

    public AutomatedUITests() => _driver = new ChromeDriver();

    public void Dispose() 
    {
        _driver.Quit(); 
        _driver.Dispose(); 
    }
    
    [Fact] 
    public void Create_WhenExecuted_ReturnsCreateView() 
    { 
        _driver.Navigate()
            .GoToUrl("https://localhost:5001/Employees/Create"); 
            
        Assert.Equal("Create - EmployeesApp", _driver.Title); 
        Assert.Contains("Please provide a new employee data", _driver.PageSource);
    }
    
    [Fact] 
    public void Create_WrongModelData_ReturnsErrorMessage() 
    { 
        _driver.Navigate()
            .GoToUrl("https://localhost:5001/Employees/Create"); 
            
        _driver.FindElement(By.Id("Name"))
            .SendKeys("Test Employee"); 
            
        _driver.FindElement(By.Id("Age"))
            .SendKeys("34"); 
            
        _driver.FindElement(By.Id("Create"))
            .Click(); 
            
        var errorMessage = _driver.FindElement(By.Id("AccountNumber-error")).Text; 
            
        Assert.Equal("Account number is required", errorMessage); 
    }
    
    [Fact] 
    public void Create_WhenSuccessfullyExecuted_ReturnsIndexViewWithNewEmployee() 
    { 
        _driver.Navigate()
            .GoToUrl("https://localhost:5001/Employees/Create"); 
                
        _driver.FindElement(By.Id("Name"))
            .SendKeys("Another Test Employee "); 
                
        _driver.FindElement(By.Id("Age"))
            .SendKeys("34"); 
                
        _driver.FindElement(By.Id("AccountNumber"))
            .SendKeys("123-9384613085-58"); 
                
        _driver.FindElement(By.Id("Create"))
            .Click(); 
                
        Assert.Equal("Index - EmployeesApp", _driver.Title); 
        Assert.Contains("Another Test Employee ", _driver.PageSource); 
        Assert.Contains("34", _driver.PageSource); 
        Assert.Contains("123-9384613085-58", _driver.PageSource); 
    }
}