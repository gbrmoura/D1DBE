def print_matrix(matrix):

    for x in range (0, len(matrix)):
        for y in range(0, len(matrix[x])):
            print(f' {matrix[x][y]} ', end=' ')

        print('', end='\n')

def main():
    try:
        print('Por favor informar os valores para preencher uma matrix (3x4):')

        row_arr = []
        for x in range(0, 3):
            column_arr = []
            for y in range(0, 4):
                value = int(input(f'Informar o valor da linha {x} e coluna {y} \n valor:'))
                column_arr.append(value)
            row_arr.append(column_arr)

        print_matrix(row_arr)
        print('\n --- \n')

        inverse_row_arr = []
        for x in range(0, len(row_arr[0])):
            inverse_column_arr = []
            for y in range(0, len(row_arr)):
                inverse_column_arr.append(row_arr[y][x])
            inverse_row_arr.append(inverse_column_arr)

        print_matrix(inverse_row_arr)

    except:
        print(f'Não foi possivel fazer calculos devido ao erro interno')


main()