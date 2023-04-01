def dec_to_hex(n):
    if n == 0:
        return 0
    hex_map = {10: 'A', 11: 'B', 12: 'C', 13: 'D', 14: 'E', 15: 'F'}
    hex = ""
    while n > 0:
        r = n % 16
        if r < 10:
            hex = str(r) + hex
        else:
            hex = hex_map[r] + hex
        n //= 16
    return hex

def dec_to_bin(n):
    if n == 0:
        return 0
    binary = ""
    while n > 0:
        r = n % 2
        binary = str(r) + binary
        n //= 2
    return binary
