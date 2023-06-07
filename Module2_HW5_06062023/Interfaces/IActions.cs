namespace Module2_HW5_06062023.Interfaces
{
    using Module2_HW5_06062023.Exeptions;

    public interface IActions
    {
        bool StartMethod();

        BusinessException SkippedMethod();

        bool BrokenMethod();
    }
}
