def is_prime_numer(value):
    if (value == 0 or value == 1):
        return False
    
    for i in range(2, int(value / 2) + 1):
        if (value % i == 0):
            return False

    return True

def print_matrix(matrix):

    for x in range (0, len(matrix)):
        for y in range(0, len(matrix[x])):
            value = matrix[x][y]
            print(f'{'*' if is_prime_numer(value) else ''}{value} ', end=' ')

        print('', end='\n')

def main():
    try:
        
        count = 1
        row = []
        for x in range (0, 10):
            column = []
            for y in range(0, 10):
                column.append(count)
                count += 1
            row.append(column)

        print_matrix(row)
    except:
        print(f'Não foi possivel fazer calculos devido ao erro interno')


main()