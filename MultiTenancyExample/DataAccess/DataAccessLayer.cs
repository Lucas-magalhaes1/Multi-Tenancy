using System.Collections.Generic;
using System.Linq;

public class DataAccessLayer
{
    public List<DataObject> GetDataForCurrentTenant()
    {
        // Simulação de uma consulta ao banco de dados
        var data = new List<DataObject>
        {
            new DataObject { Id = 1, TenantId = 1, Data = "Dados do inquilino 1" },
            new DataObject { Id = 2, TenantId = 2, Data = "Dados do inquilino 2" }
        };

        // Filtra os dados pelo inquilino atual
        return data.Where(d => d.TenantId == TenantContext.CurrentTenantId).ToList();
    }
}