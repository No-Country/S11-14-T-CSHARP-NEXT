import React from 'react';

interface SpanProps {
  text: string;
  className: string;
}

const ErrorSpan: React.FC<SpanProps> = (props) => {
  return (
    <span className={props.className}>
      {props.text}
    </span>
  );
};

export default ErrorSpan;