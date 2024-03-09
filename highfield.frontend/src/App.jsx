import { useState, useEffect } from 'react';
import './App.css';

import axios from 'axios';

import UserTable from './components/UserTable';
import ColoursTable from './components/ColoursTable';

function App() {
    const [data, setData] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    useEffect(() => {
        const getData = async () => {
            try {
                const response = await axios.get(
                    `https://localhost:7102/api/User`
                );

                setData(response.data);
                setError(null);
            }
            catch (ex) {
                setData(null);
                setError(ex.message);
            }
            finally { setLoading(false); }
        };

        getData();
    }, []);

    return (
        <>
            <h1>Highfield Technical Task</h1>
            {loading && (
                <div>
                    <p>Loading API Data...</p>
                </div>
            )}
            {error && (
                <div>
                    <p>{`Error fetching API data: ${error}`}</p>
                </div>
            )}
            {data && (
                <>
                    <div>
                        <h2>User Details</h2>
                        <UserTable users={data.users} ages={data.ages} />
                    </div>

                    <hr></hr>

                    <div>
                        <h2>Top Colours</h2>
                        <ColoursTable colours={data.topColours} />
                    </div>
                </>
            )}
        </>
    );
}

export default App;
