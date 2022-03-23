using Curve;
from mpl_toolkits.mplot3d import axes3d
import numpy as np

public void plot_block_outline(block Block,ax axes3d) {
  IMAX,JMAX,KMAX = block.X.shape;
  X = block.X;
  Y = block.Y;
  Z = block.Z;

  for (int i = 0; i < IMAX-1; i++) {    // Plots curves at constant I bounds
    for (int j = 0; j < JMAX-1; j++) {
      for(int k = 0; k < KMAX-1; k++) {
        x = X[i,j,k];
        y = Y[i,j,k];
        z = Z[i,j,k];
        curve rows = new curve(x,y,z);
    }
  }
  for (int j = 0; j < JMAX-1; j++){    // Plots curves at constant I bounds
      for (int k = 0; k < KMAX-1; k++){
        for (int i = 0; i < IMAX-1; i++) {
          x = X[i,j,k];
          y = Y[i,j,k];
          z = Z[i,j,k];
          curve rowAndCol = new curve(x,y,z);
        }
      }
  }
  for (int i = 0; i < IMAX-1; i++){    // Plots curves at constant I bounds
      for (int k = 0; k < KMAX-1; k++){
        for(int j = 0; j < JMAX-1; j++) {
          x = X[i,j,k];
          y = Y[i,j,k];
          z = Z[i,j,k];
          curve columns = new curve(x,y,z);
        }
      }
  }
}
