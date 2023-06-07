namespace Module2_HW5_06062023.Interfaces
{
    using Module2_HW5_06062023.Exeptions;

    public interface IActions
    {
        Result StartMethod();

        BusinessException SkippedMethod();

        Result BrokenMethod();
    }
}
