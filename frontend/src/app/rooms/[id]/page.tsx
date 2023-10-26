'use client';
import { NextPage } from 'next';
import { useParams } from 'next/navigation';
import React from 'react';

const RoomPage: NextPage = () => {
  const { id } = useParams();
  return (
    <div>
      <h1>RoomPage</h1>
      <span>Habitación Nº {id}</span>
    </div>
  );
};

export default RoomPage;
