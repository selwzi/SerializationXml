using ConsoleApp1;

RequestBenefit request = RequestBenefit.LoadFromXml("input.xml");
request.OwnerFirstName = "Daniel";
request.SaveToXml("output.xml");
