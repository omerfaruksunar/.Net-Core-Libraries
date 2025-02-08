// See https://aka.ms/new-console-template for more information

using Solid.App.DIPGoodAndBad;
using Solid.App.SRP.Bad;

//var CarService = new CarService(new CarRepositoryFromMSSqlServer());
var CarService = new CarService(new CarRepositoryFromPostgreSqlServer());


CarService.GetAll().ForEach(x => Console.WriteLine(x));
