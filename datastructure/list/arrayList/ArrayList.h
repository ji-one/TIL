#ifndef ARRAYLIST_H
#define ARRAYLIST_H

template <typename T>

class ArrayList
{
private:
    T *arr;
    int numOfData = 0;
    int arrLength = 2;

public:
    ArrayList()
    {
        this->arr = new T[this->arrLength];
    }

    void insert(T data)
    {
        if (this->numOfData >= this->arrLength)
        {
            this->arrLength *= 2;
            T *tmp = new T[this->arrLength];

            for (int i = 0; i < this->numOfData; i++)
            {
                tmp[i] = this->arr[i];
            }
            this->arr = tmp;
        }

        this->arr[this->numOfData++] = data;
    }

    void pop_back()
    {
        this->numOfData--;
    }

    bool isEmpty()
    {
        return this->numOfData;
    }

    int size()
    {
        return this->numOfData;
    }

    T get(int pos)
    {
        return this->arr[pos];
    }

    ~ArrayList()
    {
        delete[] arr;
    }
};
#endif