namespace xino.DEL.Entity
{
    public class ExhibitionRule
    {
        public int Id { get; set; }

        // عنوان کوتاه قانون
        public string Title { get; set; }

        // شرح کامل قانون (متن)
        public string Description { get; set; }

        // نوع قانون (مثال: تعیین محل غرفه، ساخت غرفه، تخریب، مدارک)
        public RuleType RuleType { get; set; }

        // نوع غرفه قانون مربوطه (مثلا تجهیز / بدون تجهیز / همه)
        public BoothType BoothType { get; set; }

        // حداقل مقدار (مثلا حداقل متراژ، اگر قانون متراژ است)
        public double? MinValue { get; set; }

        // حداکثر مقدار (مثلا حداکثر زمان ساخت یا متراژ)
        public double? MaxValue { get; set; }

        // واحد مقدار (مثلا "روز" برای زمان، "متر مربع" برای متراژ)
        public string ValueUnit { get; set; }

        // اگر قانون با بازه زمانی فعال است (اختیاری)
        public DateTime? EffectiveFrom { get; set; }
        public DateTime? EffectiveTo { get; set; }

        // تاریخی که قانون در دیتابیس ایجاد شده است
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }

    public enum RuleType
    {
        LocationDetermination,   // تعیین محل غرفه
        Documentation,            // مدارک غرفه‌سازی
        ConstructionDuration,     // زمان ساخت
        DemolitionDuration,       // زمان تخریب
        ParticipationCondition,   // شرایط مشارکت
        Other                     // موارد دیگر
    }

    public enum BoothType
    {
        Equipped,     // غرفه با تجهیز
        UnEquipped,   // غرفه بدون تجهیز
        All           // همه نوع غرفه
    }
}
