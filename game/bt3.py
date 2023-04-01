import math

# Khởi tạo hàm kiểm tra số nguyên tố
def laSoNguyenTo(n):
    # Số nguyên n < 2 không phải là số nguyên tố
    if (n < 2):
        return False
    # Kiểm tra số nguyên tố khi n >= 2
    m = int(math.sqrt(n))
    for i in range(2, m + 1):
        if (n % i == 0):
            return False
    return True

# Nhập và in ra số nguyên dương n
n = int(input("Nhập số nguyên dương n = "))
print("Tất cả các số nguyên tố nhỏ hơn", n, "là:")
if (n >= 2):
    print(2)
for i in range(3, n + 1):
    if (laSoNguyenTo(i)):
        print(i)
