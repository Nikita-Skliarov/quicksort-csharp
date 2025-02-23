# QuickSort Implementation

This repository contains two console applications implementing the QuickSort algorithm using different partition schemes:

- **Hoare Partition Scheme**
- **Lomuto Partition Scheme**

Additionally, there is a shared class library that contains helper methods used by both implementations.

## Project Structure

```
/QuicksortLib         - Class Library containing shared methods and partition logic
  ├── HoareQuickSortClass.cs  - Hoare partition-based QuickSort implementation
  ├── LomutoQuickSortClass.cs - Lomuto partition-based QuickSort implementation
  ├── SharedMethods.cs        - Common utility methods (e.g., Swap)

/hoare-partition-scheme    - Console application using Hoare's partition scheme
/lomuto-partition-scheme   - Console application using Lomuto's partition scheme
```

## How to Start

### Clone the Repository
```sh
git clone <repo_url>
cd <repo_directory>
```

### Open a Solution
- Navigate to either `HoareQuickSortApp.sln` or `LomutoQuickSortApp.sln`.
- Open it in Visual Studio or your preferred .NET IDE.

### Build and Run
- Build the project using the IDE's build option.
- Run the console application to see QuickSort in action.

