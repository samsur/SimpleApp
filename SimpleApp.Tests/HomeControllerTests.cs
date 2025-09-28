using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using SimpleApp.Controllers;
using SimpleApp.Models;
using System.Diagnostics;
namespace SimpleApp.Tests;

public class HomeControllerTests
{
    private readonly Mock<ILogger<HomeController>> _mockLogger;
    private readonly HomeController _controller;

    public HomeControllerTests()
    {
        _mockLogger = new Mock<ILogger<HomeController>>();
        _controller = new HomeController(_mockLogger.Object);

    }
    [Fact]
    public void Index_ReturnsViewResult()
    {
        //Act
        var result = _controller.Index();
        //Assert
        Assert.IsType<ViewResult>(result);
    }
    [Fact]
    public void Index_ReturnsProductArrayAsModel()
    {
        //Act
        var result = _controller.Index();

        //Assert
        var viewResult = result as ViewResult;
        Assert.IsAssignableFrom<Product[]>(viewResult?.Model);

    }

    [Fact]
    public void Index_ReturnsTwoProducts()
    {
        //Act
        var result = _controller.Index();

        //Assert
        var viewResult = result as ViewResult;
        var products = viewResult?.Model as Product[];
        Assert.Equal(2, products?.Length);
    }





}