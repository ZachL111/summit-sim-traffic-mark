using SummitSimTrafficMark;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(77, 35, 20, 61);
        if (DomainReviewLens.Score(item) != 190) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
