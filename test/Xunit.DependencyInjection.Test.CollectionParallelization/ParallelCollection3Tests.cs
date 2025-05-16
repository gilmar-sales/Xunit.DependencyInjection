namespace Xunit.DependencyInjection.Test.CollectionParallelization;

public class ParallelCollection3Tests(ConcurrencyFixture fixture) : IClassFixture<ConcurrencyFixture>
{
    [Fact]
    public Task Fact1() => fixture.CheckConcurrencyAsync();

    [Fact]
    public Task Fact2() => fixture.CheckConcurrencyAsync();

    [Fact]
    public Task Fact3() => fixture.CheckConcurrencyAsync();
}
