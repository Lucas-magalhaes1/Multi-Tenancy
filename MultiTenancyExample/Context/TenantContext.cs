public class TenantContext
{
    public static int CurrentTenantId { get; private set; }

    public static void SetCurrentTenantId(int tenantId)
    {
        CurrentTenantId = tenantId;
    }
}
