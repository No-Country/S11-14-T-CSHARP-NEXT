'use client';
import { NextUIProvider } from '@nextui-org/react';

interface Props {
  children: React.ReactNode;
}

const Provider: React.FC<Props> = ({ children }) => {
  return <NextUIProvider>{children}</NextUIProvider>;
};

export default Provider;
