using System;
using System.Collections.Generic;

public class Solution {
    public int RobotSim(int[] commands, int[][] obstacles) {
        // Directions: North, East, South, West
        int[][] directions = new int[][] {
            new int[] {0, 1}, // North
            new int[] {1, 0}, // East
            new int[] {0, -1}, // South
            new int[] {-1, 0} // West
        };
        
        // Set for storing obstacles
        HashSet<string> obstacleSet = new HashSet<string>();
        foreach (var obstacle in obstacles) {
            obstacleSet.Add(obstacle[0] + "," + obstacle[1]);
        }
        
        int x = 0, y = 0; // Starting position
        int directionIndex = 0; // Start facing North
        int maxDistanceSquared = 0;
        
        foreach (var command in commands) {
            if (command == -2) { // Turn left
                directionIndex = (directionIndex + 3) % 4;
            } else if (command == -1) { // Turn right
                directionIndex = (directionIndex + 1) % 4;
            } else {
                // Move forward 'command' steps
                for (int i = 0; i < command; i++) {
                    int nextX = x + directions[directionIndex][0];
                    int nextY = y + directions[directionIndex][1];
                    
                    // Check if the next position is an obstacle
                    if (obstacleSet.Contains(nextX + "," + nextY)) {
                        break; // Stop moving in this direction
                    }
                    
                    // Update current position
                    x = nextX;
                    y = nextY;
                    
                    // Calculate and update the max distance squared
                    int distanceSquared = x * x + y * y;
                    maxDistanceSquared = Math.Max(maxDistanceSquared, distanceSquared);
                }
            }
        }
        
        return maxDistanceSquared;
    }
}
