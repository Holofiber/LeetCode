using System.Collections.Generic;
using System.Linq;

// https://leetcode.com/problems/seat-reservation-manager/
public class SeatManager
{
    private List<int> unreserved = new();
    private Seat[] seats;
    private int maxReserved = 0;

    public SeatManager(int n)
    {
        GenerateSeats(n);
    }

    public int Reserve()
    {
        int lastReserved = GetFreeSeat();
        if (maxReserved < lastReserved)
        {
            maxReserved = lastReserved;
        }

        return lastReserved;
    }

    public void Unreserve(int seatNumber)
    {
        seats[seatNumber - 1].IsFree = true;

        unreserved.Add(seatNumber);
    }

    private int GetFreeSeat()
    {
        Seat freeSeat;

        // If we have ureserved, get free seat from this list
        if (unreserved.Count > 0)
        {
            unreserved.Sort();
            freeSeat = seats[unreserved.First() - 1];
            unreserved.RemoveAt(0);
        }
        // else we always know next free seat and not need to search all array
        else
            freeSeat = seats[maxReserved];

        if (freeSeat == null)
        {
            freeSeat.IsFree = false;

            return freeSeat.SeatNumber;
        }
        else
        {
            freeSeat.IsFree = false;
            return freeSeat.SeatNumber;
        }
    }

    private void GenerateSeats(int number)
    {
        seats = new Seat[number];

        for (int i = 0; i < number; i++)
            seats[i] = new Seat() { SeatNumber = i + 1, IsFree = true };
    }
}

public class Seat
{
    public int SeatNumber;

    public bool IsFree;
}

