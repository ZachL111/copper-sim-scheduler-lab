using CopperSimSchedulerLab;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(42, 44, 20, 81);
        if (DomainReviewLens.Score(item) != 149) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
