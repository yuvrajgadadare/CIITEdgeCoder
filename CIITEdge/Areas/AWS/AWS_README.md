# AWS Area for CIIT Stack Lab

This AWS module is integrated into the existing CIITEdge project without changing non-AWS application files.

## UI contract
- Uses the existing global `~/Views/Shared/_Layout.cshtml` for CIIT header and footer.
- Uses the established CIIT/C# `COURSE SYLLABUS` sidebar pattern: sticky, scrollable, module headings and active topic.
- Uses an AWS lesson hero only inside the AWS content area, keeping the CIIT site identity.
- Every lesson has Back/Next navigation and a small 4-option knowledge test with immediate feedback.
- AWS history is taught only in the Introduction lesson.
- Project-specific mapping is reserved for the final project; regular lessons focus on the AWS concept itself.

## Console screenshots
S3 screenshots are supplied as learning references and annotated with numbered callouts. They are not guaranteed to match every future AWS Console UI change.

## Safety
Students should use their own AWS account, check billing, keep public access disabled unless required, and clean up lab resources.
