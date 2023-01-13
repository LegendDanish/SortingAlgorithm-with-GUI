using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.Xml;
using Guna.UI2.WinForms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.IdentityModel.Claims;

namespace SortingAlgorithm
{
    public class CredentialDL
    {
        public static Random random = new Random();
        public static List<Credential> readData(string path)
        {
            List<Credential> record = new List<Credential>();
            StreamReader myFile = new StreamReader(path);
            string line;
            myFile.ReadLine();
            
            if (File.Exists(path))
            {
                while ((line = myFile.ReadLine()) != null)
                {
                   

                    if (!string.IsNullOrEmpty(line))
                    {
                        int index = int.Parse(parse(line, 1));
                        string organizationID = parse(line, 2);
                        string name = parse(line, 3);
                        string website = parse(line, 4);
                        string country = parse(line, 5);
                        string description = parse(line, 6);
                        int founded = int.Parse(parse(line, 7));
                        string industry = parse(line, 8);
                        int noOfEmployees = int.Parse(parse(line, 9));
                        Credential cre = new Credential(index, founded, noOfEmployees, organizationID, name, website, country, description, industry);
                        record.Add(cre);
                    }
                    else
                    {
                        myFile.Close();
                    }
                }
                myFile.Close();
            }
            return record;
        }

        public static void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        public static string parse(string line, int find)
        {
            bool flag = true;
            string parse = "";
            int commas = 1;
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == ',')
                {
                    if (flag)
                    {
                        commas++;
                    }
                }
                else if (commas == find)
                {
                    parse = parse + line[i];
                }
                if (line[i] == '"')
                {
                    flag = false;
                    count++;
                }
                if (count == 2)
                {
                    flag = true;
                    count = 0;
                }

            }
            return parse;
        }
       
        public static List<Credential> bubbleSort(List<Credential> record, bool flag)
        {
            int size = record.Count;
            for (int x = 0; x < size - 1; x++)
            {
                bool isSwapped = false;
                for (int y = 0; y < size - x - 1; y++)
                {
                    int temp1, temp2;
                    if (flag)
                    {
                        temp1 = record[y].Index;
                        temp2 = record[y + 1].Index;
                    }
                    else
                    {
                        temp1 = record[y].NoOfEmployees;
                        temp2 = record[y + 1].NoOfEmployees;
                    }
                    if (temp1 > temp2)
                    {
                        Credential temp = record[y];
                        record[y] = record[y + 1];
                        record[y + 1] = temp;
                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                {
                    break;
                }
            }
            return record;
        }

        public static List<Credential> insertionSort(List<Credential> record, bool flag)
        {
            int size = record.Count;
            for (int x = 1; x < size; x++)
            {
                for(int y = x; y > 0; y--)
                {
                    int temp1, temp2;
                    if(flag)
                    {
                        temp1 = record[y].Index;
                        temp2 = record[y - 1].Index;
                    }
                    else
                    {
                        temp1 = record[y].NoOfEmployees;
                        temp2 = record[y - 1].NoOfEmployees;
                    }
                    if(temp1 < temp2)
                    {
                        Credential temp = record[y-1];
                        record[y-1] = record[y];
                        record[y] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return record;
        }

        public static int findMinimum(List<Credential> record, int start, int end, bool flag)
        {
            int min;
            if (flag)
            {
                min = record[start].Index;
            }
            else
            {
                min = record[start].NoOfEmployees;
            }

            int minIndex = start;
            for (int x = start; x < end; x++)
            {
                int temp;
                if (flag)
                {
                    temp = record[x].Index;
                }
                else
                {
                    temp = record[x].NoOfEmployees;
                }
                if (min > temp)
                {
                    min = temp;
                    minIndex = x;
                }
            }
            return minIndex;
        }

        public static List<Credential> selectionSort(List<Credential> record, bool flag)
        {
            int size = record.Count;
            for (int x = 0; x < size - 1; x++)
            {
                int minIndex = findMinimum(record, x, size, flag);
                Credential temp = record[x];
                record[x] = record[minIndex];
                record[minIndex] = temp;
            }
            return record;
        }

        public static void mergeEmployess(ref List<Credential> arr, int start, int mid, int end)
        {
            int i = start;
            int j = mid + 1;
            Queue<Credential> tempArr = new Queue<Credential>();
            while (i <= mid && j <= end)
            {
                if (arr[i].NoOfEmployees < arr[j].NoOfEmployees)
                {
                    tempArr.Enqueue(arr[i]);
                    i++;
                }
                else
                {
                    tempArr.Enqueue(arr[j]);
                    j++;
                }
            }
            while (i <= mid)
            {
                tempArr.Enqueue(arr[i]);
                i++;
            }
            while (j <= end)
            {
                tempArr.Enqueue(arr[j]);
                j++;
            }
            for (int x = start; x <= end; x++)
            {
                arr[x] = tempArr.Dequeue();
            }
        }
        public static void mergeIndex(ref List<Credential> arr, int start, int mid, int end)
        {
            int i = start;
            int j = mid + 1;
            Queue<Credential> tempArr = new Queue<Credential>();
            while (i <= mid && j <= end)
            {
                if (arr[i].Index < arr[j].Index)
                {
                    tempArr.Enqueue(arr[i]);
                    i++;
                }
                else
                {
                    tempArr.Enqueue(arr[j]);
                    j++;
                }
            }
            while (i <= mid)
            {
                tempArr.Enqueue(arr[i]);
                i++;
            }
            while (j <= end)
            {
                tempArr.Enqueue(arr[j]);
                j++;
            }
            for (int x = start; x <= end; x++)
            {
                arr[x] = tempArr.Dequeue();
            }
        }
        public static void mergeSort(ref List<Credential> arr, int start, int end, bool flag)
        {
            if (start < end)
            {
                int mid = (start + end) / 2;
                mergeSort(ref arr, start, mid, flag);
                mergeSort(ref arr, mid + 1, end, flag);
                if (flag)
                {
                    mergeIndex(ref arr, start, mid, end);
                }
                else
                {
                    mergeEmployess(ref arr, start, mid, end);
                }
            }
        }
        
        public static int partitionIndex(ref List<Credential> arr, int start, int end, bool flag)
        {
            randomIndex(ref arr, start, end, true);
            int pivot = arr[end].Index;
            int i = (start - 1); // index of smaller element 
            for (int j = start; j < end; j++)
            {
                if (arr[j].Index < pivot)
                {
                    i++;
                    Credential tempp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tempp;
                }
            }
            Credential tempp2 = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = tempp2;
            return i + 1;
           
        }
        
        public static int partitionEmployees(ref List<Credential> arr, int start, int end, bool flag)
        {
            int left = start;
            int right = end;
            randomIndex(ref arr, start, end, false);
            int pivot = arr[end].NoOfEmployees;
            int i = (start - 1); // index of smaller element 
            for (int j = start; j < end; j++)
            {
                if (arr[j].NoOfEmployees < pivot)
                {
                    i++;
                    Credential tempp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tempp;
                }
            }
            Credential tempp2 = arr[i + 1];
            arr[i + 1] = arr[end];
            arr[end] = tempp2;
            return i + 1;
           
        }

        public static int randomIndex(ref List<Credential> arr, int low, int high, bool flag)
        {
            Random rand = new Random();
            int pivot = rand.Next() % (high - low) + low;
            Credential tempp1 = arr[pivot];
            arr[pivot] = arr[high];
            arr[high] = tempp1;
            if(flag)
            {
                return partitionIndex(ref arr, low, high, true);
            }
            return partitionEmployees(ref arr, low, high, false);
        }
        public static void quickSort(ref List<Credential> arr, int start, int end, bool flag)
        {
            if (start < end)
            {
                int m = start;
                if (flag)
                {
                    for (int i = start + 1; i <= end; i++)
                        if (arr[i].Index < arr[start].Index)
                        {
                            int n = ++m;
                            Credential temp = arr[n];
                            arr[n] = arr[i];
                            arr[i] = temp;
                        }
                }
                else
                {
                    for (int i = start + 1; i <= end; i++)
                        if (arr[i].NoOfEmployees < arr[start].NoOfEmployees)
                        {
                            int n = ++m;
                            Credential temp = arr[n];
                            arr[n] = arr[i];
                            arr[i] = temp;
                        }
                }
                Credential tempp1 = arr[start];
                arr[start] = arr[m];
                arr[m] = tempp1;
                quickSort(ref arr, start, m - 1, flag);
                quickSort(ref arr, m + 1, end, flag);
            }
        }

        public static int parentIndex(int i)
        {
            return (i - 1) / 2;
        }
        public static int leftChildIndex(int i)
        {
            return (2 * i) + 1;
        }
        public static int rightChildIndex(int i)
        {
            return (2 * i) + 2;
        }

        public static void heapifyIndex(ref List<Credential> heapArr, int size, int index)
        {
            int maxIndex;
            while (true)
            {
                int lIdx = leftChildIndex(index);
                int rIdx = rightChildIndex(index);
                if (rIdx >= size)
                {
                    if (lIdx >= size)
                        return;
                    else
                        maxIndex = lIdx;
                }
                else
                {
                    if (heapArr[lIdx].Index >= heapArr[rIdx].Index)
                        maxIndex = lIdx;
                    else
                        maxIndex = rIdx;
                }
                if (heapArr[index].Index < heapArr[maxIndex].Index)
                {
                    Credential temp = heapArr[index];
                    heapArr[index] = heapArr[maxIndex];
                    heapArr[maxIndex] = temp;
                    index = maxIndex;
                }
                else
                    return;
            }
        }

        public static void heapifyEmployess(ref List<Credential> heapArr, int size, int index)
        {
            int maxIndex;
            while (true)
            {
                int lIdx = leftChildIndex(index);
                int rIdx = rightChildIndex(index);
                if (rIdx >= size)
                {
                    if (lIdx >= size)
                        return;
                    else
                        maxIndex = lIdx;
                }
                else
                {
                    if (heapArr[lIdx].NoOfEmployees >= heapArr[rIdx].NoOfEmployees)
                        maxIndex = lIdx;
                    else
                        maxIndex = rIdx;
                }
                if (heapArr[index].NoOfEmployees < heapArr[maxIndex].NoOfEmployees)
                {
                    Credential temp = heapArr[index];
                    heapArr[index] = heapArr[maxIndex];
                    heapArr[maxIndex] = temp;
                    index = maxIndex;
                }
                else
                    return;
            }
        }

        public static void heapSort(ref List<Credential> heapArr, int size, bool flag)
        {
            for (int x = (size / 2) - 1; x >= 0; x--)
            {
                if (flag)
                {
                    heapifyIndex(ref heapArr, size, x);
                }
                else
                {
                    heapifyEmployess(ref heapArr, size, x);
                }
            }
            for (int x = size - 1; x > 0; x--)
            {
                Credential temp = heapArr[x];
                heapArr[x] = heapArr[0];
                heapArr[0] = temp;
                if (flag)
                {
                    heapifyIndex(ref heapArr, x, 0);
                }
                else
                {
                    heapifyEmployess(ref heapArr, x, 0);
                }
            }
        }
        
        public static int max(List<Credential> arr, bool flag)
        {
            int max;
            if (flag)
            {
                max = arr[0].Index;
            }
            else
            {
                max = arr[0].NoOfEmployees;
            }
            for(int i = 1; i< arr.Count; i++)
            {
                int value;
                if(flag)
                {
                    value = arr[i].Index;
                }
                else
                {
                    value = arr[i].NoOfEmployees;
                }
                if(max < value)
                {
                    max = value;
                }
            }
            return max;
        }

        public static int min(List<Credential> arr, bool flag)
        {
            int min;
            if (flag)
            {
                min = arr[0].Index;
            }
            else
            {
                min = arr[0].NoOfEmployees;
            }
            for (int i = 1; i < arr.Count; i++)
            {
                int value;
                if (flag)
                {
                    value = arr[i].Index;
                }
                else
                {
                    value = arr[i].NoOfEmployees;
                }
                if (min > value)
                {
                    min = value;
                }
            }
            return min;
        }


        public static void countingSortIndex(ref List<Credential> arr,int place, bool flag, bool radix)
        {
            int range =0, maximum=0, minimum=0;
            if(radix)
            {
                range = 10;
            }
            else
            {
                maximum = max(arr, true);
                minimum = min(arr, true);
                range = maximum - minimum + 1;
            }
            
            List<int> count = new List<int>(new int[range]);
            List<Credential> output = new List<Credential>(new Credential[arr.Count]);

            for(int i = 0; i< arr.Count; i++)
            {
                if(radix)
                {
                    count[((arr[i].Index / place) % 10)]++;
                }
                else
                {
                    count[arr[i].Index - minimum]++;
                } 
            }
            for(int i = 1; i<count.Count; i++)
            {
                count[i] += count[i - 1];
            }
            for(int i = arr.Count - 1; i >= 0; i--)
            {
                if(radix)
                {
                    output[count[((arr[i].Index / place) % 10)] - 1] = arr[i];
                    count[((arr[i].Index / place) % 10)]--;
                }
                else
                {
                    output[count[arr[i].Index - minimum] - 1] = arr[i];
                    count[arr[i].Index - minimum]--;
                }
            }
            arr = output;
        }

        public static void countingSortEmployee(ref List<Credential> arr,int place, bool flag, bool radix)
        {
            int range = 0, maximum = 0, minimum = 0;
            if (radix)
            {
                range = 10;
            }
            else
            {
                maximum = max(arr, false);
                minimum = min(arr, false);
                range = maximum - minimum + 1;
            }
            List<int> count = new List<int>(new int[range]);
            List<Credential> output = new List<Credential>(new Credential[arr.Count]);

            for (int i = 0; i < arr.Count; i++)
            {
                if(radix)
                {
                    count[(arr[i].NoOfEmployees / place) % 10]++;
                }
                else
                {
                    count[arr[i].NoOfEmployees - minimum]++;
                }
               
            }
            for (int i = 1; i < count.Count; i++)
            {
                count[i] += count[i - 1];
            }
            for (int i = arr.Count - 1; i >= 0; i--)
            {
                if(radix)
                {
                    output[count[(arr[i].NoOfEmployees / place) % 10] - 1] = arr[i];
                    count[(arr[i].NoOfEmployees / place) % 10]--;
                }
                else
                {
                    output[count[arr[i].NoOfEmployees- minimum] - 1] = arr[i];
                    count[arr[i].NoOfEmployees- minimum]--;
                }
            }
            arr = output;
        }

        public static void radixSortIndex(ref List<Credential> arr)
        {
            int maximum = max(arr, true);
            int place = 1;
            while(maximum /place > 0)
            {
                countingSortIndex(ref arr, place, true, true);
                place *= 10;
            }
        }
        public static void radixSortEmployee(ref List<Credential> arr)
        {
            int maximum = max(arr, false);
            int place = 1;
            while (maximum / place > 0)
            {
                countingSortEmployee(ref arr, place, true, false);
                place *= 10;
            }
        }
        public static void bucketSort(ref List<Credential> arr, bool flag)
        {
            int maximum;
            if (flag){
                maximum = max(arr, true);
            }
            else{
                maximum = max(arr, false);
            }
            List<List<Credential>> bucket = new List<List<Credential>>(new List<Credential>[maximum+1]);
            for (int i = 0; i < arr.Count; i++)
            {
                List<Credential> list = new List<Credential>();
                int idx;
                if (flag)
                {
                    idx = arr[i].Index;
                }
                else
                {
                    idx = arr[i].NoOfEmployees;
                }
                if (bucket[idx] != null)
                {
                    bucket[idx].Add(arr[i]);
                }
                else
                {
                    bucket[idx] = list;
                    bucket[idx].Add(arr[i]);
                }
            }
            int index = 0;
            for (int i = 0; i < bucket.Count - 1; i++)
            {
                if (bucket[i] != null)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                        arr[index++] = bucket[i][j];
                }
            }
        }
    }
}
