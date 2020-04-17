<Query Kind="Expression">
  <Connection>
    <ID>593e4eba-044a-4c0f-bdbe-7a5a090e0ff6</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Driver Assembly="(internal)" PublicKeyToken="no-strong-name">LINQPad.Drivers.EFCore.DynamicDriver</Driver>
    <Server>SINJULMSBH\MSSQLSERVERS2019</Server>
    <Database>LinqPadDemoDB</Database>
    <AlphabetizeColumns>true</AlphabetizeColumns>
    <ConvertUnderscoresToPascal>true</ConvertUnderscoresToPascal>
    <DisplayName>LinqPadDemoDB</DisplayName>
    <DriverData>
      <EFProvider>Microsoft.EntityFrameworkCore.SqlServer</EFProvider>
    </DriverData>
  </Connection>
</Query>

from j in JackSlaters
where j.Id > 310
orderby j.Id descending
select new
{
	j.Id,
	j.SinjulMSBHId,
	j.FullName,
	j.Age,
	j.IsActive,
	j.BirthDate,
}