using System;
using System.Collections.Generic;

namespace LeetCode.Medium
{
    // https://leetcode.com/problems/seat-reservation-manager/
    public class SeatManager
    {
        private int[] seats;

        public SeatManager(int n)
        {
            seats = new int[n];
        }

        public int Reserve()
        {
            return GetFreeSeat();

        }

        public void Unreserve(int seatNumber)
        {
            int index = Array.IndexOf(seats, seatNumber);

            seats[index] = 0;
        }

        private int GetFreeSeat()
        {
            for (int i = 0; i < seats.Length; i++)
                if (seats[i] == 0)
                {
                    seats[i] = i+1;
                    return seats[i];
                }

            return 0;
        }
    }
}
