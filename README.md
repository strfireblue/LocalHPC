# LocalHPC

## Introduction
Local HPC is a system for treating local commodity hardware as a kind of HPC system for specific jobs.  Envisioned originally as a way to run large Excel workbooks in pieces locally when a full HPC environment is not available, feasible, or convenient to stand up.

## Architecture
- Postgres - Job persistance and storage
- RabbitMQ - Message Queue platform
- Submission Service - Handles submitting jobs to the local HPC environment
- Node Service - Handles nodes status on the local HPC environment
- Submission client - Desktop application allowing users to submit new jobs, see status of existing jobs
- Worker Node - Desktop application that runs the jobs
