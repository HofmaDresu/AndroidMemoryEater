# AndroidMemoryEater
Interesting look at the GC for a simple repeated case. Memory is continually consumed when explicit GC is disabled. Eventually the system will run large GC, but it only seems to happen when freespace is basically gone.

This is easiest to see by running Xamarin Profiler. The memory consumption is slow, but fairly consistent. 

1. Run the app in Profiler and click "Start"
2. Let it run for a few minutes
3. Look at the memory growth in Profiler
4. Click the "Explicit Garbage Collects" checkbox
5. Make note of the current memory consumption
6. Let it run for a few minutes
7. Check the memory consumption, it should not have grown and the usage graph should have stabilized
