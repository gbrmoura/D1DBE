def sort(arr, type):

    array_len = len(arr)

    for x in range(0, array_len):
        
        for y in range(0, array_len - x - 1):
             
            if (type =='asc' and arr[y] > arr[y + 1]):
                saved_value = arr[y]
                arr[y] = arr[y + 1]
                arr[y + 1] = saved_value
            
            if (type == 'desc' and arr[y] < arr[y+1]):
                saved_value = arr[y]
                arr[y] = arr[y + 1]
                arr[y + 1] = saved_value   

def main():
    try:
        print('Por favor informar os valores abaixo:')
        vector = []
        for i in range(0,10):
            vector.append(int(input(f'Informe o valor do index {i}: ')))

        sort(vector, 'asc')
        print(f'Vetor ordenado em ordem crescente \n {vector}')

        sort(vector, 'desc')
        print(f'Vetor ordenado em ordem decrescente \n {vector}')

    except:
        print(f'Não foi possivel fazer calculos devido ao erro interno')

main()