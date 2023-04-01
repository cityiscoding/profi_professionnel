import random

# random số từ 1 đến 50
so_ngau_nhien = random.randint(1, 50)

# số lần đoán tối đa
so_lan_doan_toi_da = 5

# cho người chơi đoán
while so_lan_doan_toi_da > 0:
    so_doan = int(input("Hãy đoán số tôi đang nghĩ từ 1 đến 50: "))
    if so_doan == so_ngau_nhien:
        print("Chính xác! Bạn đã đoán trúng.")
        break
    elif so_doan < so_ngau_nhien:
        print("Số bạn đoán nhỏ hơn kết quả.")
    else:
        print("Số bạn đoán lớn hơn kết quả.")
    so_lan_doan_toi_da -= 1

# hết số lần đoán
if so_lan_doan_toi_da == 0:
    print("Bạn đã hết số lần đoán. Kết quả đúng là {}.".format(so_ngau_nhien))