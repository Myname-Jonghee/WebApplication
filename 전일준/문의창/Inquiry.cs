namespace Ptoject_battery03.Models
{
    public class Inquiry
    {
        public int Id { get; set; }
        public string Title { get; set; }     // 문의 제목
        public string Content { get; set; }   // 문의 내용
        public string Category { get; set; }  // 문의 항목 (예: 제품, 주문 등)
        public string UserName { get; set; }  // 사용자 이름
        public string Email { get; set; }     // 사용자 이메일
        public DateTime CreatedAt { get; set; } // 문의 제출 시간
    }
}
