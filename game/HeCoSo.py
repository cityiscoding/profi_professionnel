def chuyen_doi_so_he_10_sang_he_2(so):
    # Chuyển đổi từ hệ cơ số 10 sang 2
    nhi_phan = ""
    while so > 0:
        du = so % 2
        nhi_phan = str(du) + nhi_phan
        so = so // 2
    return nhi_phan

def chuyen_doi_so_he_10_sang_he_16(so):
    #       
    hexa = ""
    while so > 0:
        du = so % 16
        if du < 10:
            hexa = str(du) + hexa
        else:
            hexa = chr(du + 55) + hexa
        so = so // 16
    return hexa

# Kiểm tra kết quả
so = 57
print("Số 57 ở hệ nhị phân là:", chuyen_doi_so_he_10_sang_he_2(so))
print("Số 57 ở hệ hexa là:", chuyen_doi_so_he_10_sang_he_16(so))

so = 235
print("Số 235 ở hệ nhị phân là:", chuyen_doi_so_he_10_sang_he_2(so))
print("Số 235 ở hệ hexa là:", chuyen_doi_so_he_10_sang_he_16(so))
