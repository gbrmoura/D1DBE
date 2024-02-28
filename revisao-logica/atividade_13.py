import random

def print_matrix(matrix):

    for x in range (0, len(matrix)):
        for y in range(0, len(matrix[x])):
            print(f' {matrix[x][y]} ', end=' ')

        print('', end='\n')

def main():
    try:
        
        row = []
        for x in range (0, 10):
            column = []
            for y in range(0, 10):
                column.append(random.randint(0, 9))
            row.append(column)

        print('\n')
        print_matrix(row)
        print('\n ----------------------------------------------------------- \n')

        for x in range (0, 10):
            for y in range(0, 10):
                 
                if (x == y):
                    row[x][y] = 1

                if (x < y):
                    row[x][y] = 0
                
                if (x > y):
                    row[x][y] = 2
                
        print_matrix(row)

    except:
        print(f'Não foi possivel fazer calculos devido ao erro interno')


main()