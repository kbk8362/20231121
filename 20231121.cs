int main(void)
{
    int i;
    n = MAX_SIZE;
    srand(time(NULL));
    for (i = 0; i < n; i++)         // 난수 생성 및 출력 
        list[i] = rand() % 100; // 난수 발생 범위 0~99

    selection_sort(list, n); // 선택정렬 호출 
    for (i = 0; i < n; i++)
        printf("%d ", list[i]);
    printf("\n");
    return 0;
}

// 삽입정렬
void insertion_sort(int list[], int n)
{
    int i, j, key;
    for (i = 1; i < n; i++)
    {
        key = list[i];
        for (j = i - 1; j >= 0 && list[j] > key; j--)
            list[j + 1] = list[j];      // 레코드의 오른쪽 이동
        list[j + 1] = key;
    }
}
 //버블정렬
#define SWAP(x, y, t) ( (t)=(x), (x)=(y), (y)=(t) )

void bubble_sort(int list[], int n)
{
    int i, j, temp;
    for (i = n - 1; i > 0; i--)
    {
        for (j = 0; j < i; j++)     // 앞뒤의 레코드를 비교한 후 교체
            if (list[j] > list[j + 1])
                SWAP(list[j], list[j + 1], temp);
    }
}
