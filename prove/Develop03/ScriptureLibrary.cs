public class ScriptureLibrary
{
    private List<Scripture> _scripture = new List<Scripture>()
    {
        new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
        new Scripture(new Reference("2 Nephi", 32, 8, 9),"And now, my beloved brethren, I perceive that ye ponder still in your hearts; and it grieveth me that I must speak concerning this thing. For if ye would hearken unto the Spirit which teacheth a man to pray, ye would know that ye must pray; for the evil spirit teacheth not a man to pray, but teacheth him that he must not pray. But behold, I say unto you that ye must pray always, and not faint; that ye must not perform any thing unto the Lord save in the first place ye shall pray unto the Father in the name of Christ, that he will consecrate thy performance unto thee, that thy performance may be for the welfare of thy soul."),
        new Scripture(new Reference("1 Nephi", 3, 1), "And it came to pass that I, Nephi, returned from speaking with the Lord, to the tent of my father.")
    };

    public Scripture GetScriptures()
    {
        Random random = new Random();
        Scripture scripture = _scripture[random.Next(0, _scripture.Count())];

        return scripture;
    }
}