print("Chương trình kiểm tra số nguyên tố")

while True:
    n = input("Nhập vào một số nguyên (nhập 'exit' để thoát chương trình): ")
    
    if n == 'exit':
        break
    
    # Kiểm tra xem đầu vào có phải là số nguyên hay không
    try:
        n = int(n)
    except ValueError:
        print("Đầu vào không hợp lệ. Vui lòng nhập lại.")
        continue
    
    # Kiểm tra số nguyên tố
    def kiem_tra_snt(n):
        if n < 2:
            return False
        for i in range(2, int(n**0.5) + 1):
            if n % i == 0:
                return False
        return True
    
    if kiem_tra_snt(n):
        print(f"{n} là số nguyên tố")
    else:
        print(f"{n} không phải là số nguyên tố")
