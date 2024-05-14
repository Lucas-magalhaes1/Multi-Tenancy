using System;

class Program
{
    static void Main()
    {
        // Define diferentes inquilinos
        TenantContext.SetCurrentTenantId(1);
        var dataAccessLayer = new DataAccessLayer();

        // Consulta para inquilino 1
        var dataForTenant1 = dataAccessLayer.GetDataForCurrentTenant();
        Console.WriteLine("Dados para o Inquilino 1:");
        foreach (var item in dataForTenant1)
        {
            Console.WriteLine($"ID: {item.Id}, Data: {item.Data}");
        }

        TenantContext.SetCurrentTenantId(2);

        // Consulta para inquilino 2
        var dataForTenant2 = dataAccessLayer.GetDataForCurrentTenant();
        Console.WriteLine("\nDados para o Inquilino 2:");
        foreach (var item in dataForTenant2)
        {
            Console.WriteLine($"ID: {item.Id}, Data: {item.Data}");
        }

        Console.ReadLine();
    }
}
